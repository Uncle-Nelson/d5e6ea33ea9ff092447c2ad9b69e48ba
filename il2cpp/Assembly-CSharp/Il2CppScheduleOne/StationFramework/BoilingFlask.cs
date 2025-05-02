using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000585 RID: 1413
	public class BoilingFlask : Fillable
	{
		// Token: 0x06007C64 RID: 31844 RVA: 0x00216D00 File Offset: 0x00214F00
		// Note: this type is marked as 'beforefieldinit'.
		static BoilingFlask()
		{
			Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "BoilingFlask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr);
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX_VELOCITY");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_ACCELERATION");
			BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OVERHEAT_TIME");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperature>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperatureVelocity>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<OverheatScale>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<Recipe>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr_LockTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LockTemperature");
			BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSoundPitchCurve");
			BoilingFlask.NativeFieldInfoPtr_LabelJitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LabelJitterScale");
			BoilingFlask.NativeFieldInfoPtr_Burner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "Burner");
			BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureCanvas");
			BoilingFlask.NativeFieldInfoPtr_TemperatureLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureLabel");
			BoilingFlask.NativeFieldInfoPtr_TemperatureSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureSlider");
			BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureRangeIndicator");
			BoilingFlask.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "SmokeParticles");
			BoilingFlask.NativeFieldInfoPtr_BoilSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSound");
			BoilingFlask.NativeFieldInfoPtr_OverheatMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OverheatMesh");
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678889);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678890);
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678891);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678892);
			BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678893);
			BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678894);
			BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678895);
			BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678896);
			BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678897);
			BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678898);
			BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678899);
			BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678900);
			BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678901);
			BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678902);
			BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678903);
			BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678904);
			BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678905);
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x00217000 File Offset: 0x00215200
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0021703C File Offset: 0x0021523C
		public unsafe float CurrentTemperature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30024, RefRangeEnd = 30025, XrefRangeStart = 30024, XrefRangeEnd = 30025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 30025, RefRangeEnd = 30028, XrefRangeStart = 30025, XrefRangeEnd = 30028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x0021707C File Offset: 0x0021527C
		// (set) Token: 0x06007C68 RID: 31848 RVA: 0x002170B8 File Offset: 0x002152B8
		public unsafe float CurrentTemperatureVelocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30028, RefRangeEnd = 30029, XrefRangeStart = 30028, XrefRangeEnd = 30029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x002170F8 File Offset: 0x002152F8
		public unsafe bool IsTemperatureInRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 237491, RefRangeEnd = 237492, XrefRangeStart = 237487, XrefRangeEnd = 237491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06007C6A RID: 31850 RVA: 0x00217134 File Offset: 0x00215334
		// (set) Token: 0x06007C6B RID: 31851 RVA: 0x00217170 File Offset: 0x00215370
		public unsafe float OverheatScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06007C6C RID: 31852 RVA: 0x002171B0 File Offset: 0x002153B0
		// (set) Token: 0x06007C6D RID: 31853 RVA: 0x002171F0 File Offset: 0x002153F0
		public unsafe StationRecipe Recipe
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00217234 File Offset: 0x00215434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237492, XrefRangeEnd = 237520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x00217268 File Offset: 0x00215468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237520, XrefRangeEnd = 237529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x0021729C File Offset: 0x0021549C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237542, RefRangeEnd = 237543, XrefRangeStart = 237529, XrefRangeEnd = 237542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x002172D0 File Offset: 0x002154D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237543, XrefRangeEnd = 237551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSmoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x00217304 File Offset: 0x00215504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237554, RefRangeEnd = 237557, XrefRangeStart = 237551, XrefRangeEnd = 237554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00217344 File Offset: 0x00215544
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30025, RefRangeEnd = 30028, XrefRangeStart = 30025, XrefRangeEnd = 30028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemperature(float temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x00217384 File Offset: 0x00215584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237566, RefRangeEnd = 237569, XrefRangeStart = 237557, XrefRangeEnd = 237566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x002173C8 File Offset: 0x002155C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237569, XrefRangeEnd = 237577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoilingFlask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x0003B040 File Offset: 0x00039240
		public BoilingFlask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00217404 File Offset: 0x00215604
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0003B049 File Offset: 0x00039249
		public unsafe static float TEMPERATURE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x00217420 File Offset: 0x00215620
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0003B057 File Offset: 0x00039257
		public unsafe float TEMPERATURE_MAX_VELOCITY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY)) = value;
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x00217448 File Offset: 0x00215648
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x0003B072 File Offset: 0x00039272
		public unsafe float TEMPERATURE_ACCELERATION
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION)) = value;
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x00217470 File Offset: 0x00215670
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x0003B08D File Offset: 0x0003928D
		public unsafe static float OVERHEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x0021748C File Offset: 0x0021568C
		// (set) Token: 0x06007C80 RID: 31872 RVA: 0x0003B09B File Offset: 0x0003929B
		public unsafe float _CurrentTemperature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField)) = value;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x002174B4 File Offset: 0x002156B4
		// (set) Token: 0x06007C82 RID: 31874 RVA: 0x0003B0B6 File Offset: 0x000392B6
		public unsafe float _CurrentTemperatureVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x002174DC File Offset: 0x002156DC
		// (set) Token: 0x06007C84 RID: 31876 RVA: 0x0003B0D1 File Offset: 0x000392D1
		public unsafe float _OverheatScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06007C85 RID: 31877 RVA: 0x00217504 File Offset: 0x00215704
		// (set) Token: 0x06007C86 RID: 31878 RVA: 0x0003B0EC File Offset: 0x000392EC
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x00217534 File Offset: 0x00215734
		// (set) Token: 0x06007C88 RID: 31880 RVA: 0x0003B10B File Offset: 0x0003930B
		public unsafe bool LockTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature)) = value;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x0021755C File Offset: 0x0021575C
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x0003B126 File Offset: 0x00039326
		public unsafe AnimationCurve BoilSoundPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x0021758C File Offset: 0x0021578C
		// (set) Token: 0x06007C8C RID: 31884 RVA: 0x0003B145 File Offset: 0x00039345
		public unsafe float LabelJitterScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale)) = value;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06007C8D RID: 31885 RVA: 0x002175B4 File Offset: 0x002157B4
		// (set) Token: 0x06007C8E RID: 31886 RVA: 0x0003B160 File Offset: 0x00039360
		public unsafe BunsenBurner Burner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunsenBurner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06007C8F RID: 31887 RVA: 0x002175E4 File Offset: 0x002157E4
		// (set) Token: 0x06007C90 RID: 31888 RVA: 0x0003B17F File Offset: 0x0003937F
		public unsafe Canvas TemperatureCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06007C91 RID: 31889 RVA: 0x00217614 File Offset: 0x00215814
		// (set) Token: 0x06007C92 RID: 31890 RVA: 0x0003B19E File Offset: 0x0003939E
		public unsafe TextMeshProUGUI TemperatureLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x00217644 File Offset: 0x00215844
		// (set) Token: 0x06007C94 RID: 31892 RVA: 0x0003B1BD File Offset: 0x000393BD
		public unsafe Slider TemperatureSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x00217674 File Offset: 0x00215874
		// (set) Token: 0x06007C96 RID: 31894 RVA: 0x0003B1DC File Offset: 0x000393DC
		public unsafe RectTransform TemperatureRangeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06007C97 RID: 31895 RVA: 0x002176A4 File Offset: 0x002158A4
		// (set) Token: 0x06007C98 RID: 31896 RVA: 0x0003B1FB File Offset: 0x000393FB
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06007C99 RID: 31897 RVA: 0x002176D4 File Offset: 0x002158D4
		// (set) Token: 0x06007C9A RID: 31898 RVA: 0x0003B21A File Offset: 0x0003941A
		public unsafe AudioSourceController BoilSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x00217704 File Offset: 0x00215904
		// (set) Token: 0x06007C9C RID: 31900 RVA: 0x0003B239 File Offset: 0x00039439
		public unsafe MeshRenderer OverheatMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054B4 RID: 21684
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX;

		// Token: 0x040054B5 RID: 21685
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY;

		// Token: 0x040054B6 RID: 21686
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_ACCELERATION;

		// Token: 0x040054B7 RID: 21687
		private static readonly IntPtr NativeFieldInfoPtr_OVERHEAT_TIME;

		// Token: 0x040054B8 RID: 21688
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperature_k__BackingField;

		// Token: 0x040054B9 RID: 21689
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField;

		// Token: 0x040054BA RID: 21690
		private static readonly IntPtr NativeFieldInfoPtr__OverheatScale_k__BackingField;

		// Token: 0x040054BB RID: 21691
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x040054BC RID: 21692
		private static readonly IntPtr NativeFieldInfoPtr_LockTemperature;

		// Token: 0x040054BD RID: 21693
		private static readonly IntPtr NativeFieldInfoPtr_BoilSoundPitchCurve;

		// Token: 0x040054BE RID: 21694
		private static readonly IntPtr NativeFieldInfoPtr_LabelJitterScale;

		// Token: 0x040054BF RID: 21695
		private static readonly IntPtr NativeFieldInfoPtr_Burner;

		// Token: 0x040054C0 RID: 21696
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureCanvas;

		// Token: 0x040054C1 RID: 21697
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureLabel;

		// Token: 0x040054C2 RID: 21698
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureSlider;

		// Token: 0x040054C3 RID: 21699
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureRangeIndicator;

		// Token: 0x040054C4 RID: 21700
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x040054C5 RID: 21701
		private static readonly IntPtr NativeFieldInfoPtr_BoilSound;

		// Token: 0x040054C6 RID: 21702
		private static readonly IntPtr NativeFieldInfoPtr_OverheatMesh;

		// Token: 0x040054C7 RID: 21703
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0;

		// Token: 0x040054C8 RID: 21704
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0;

		// Token: 0x040054C9 RID: 21705
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0;

		// Token: 0x040054CA RID: 21706
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0;

		// Token: 0x040054CB RID: 21707
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0;

		// Token: 0x040054CC RID: 21708
		private static readonly IntPtr NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0;

		// Token: 0x040054CD RID: 21709
		private static readonly IntPtr NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0;

		// Token: 0x040054CE RID: 21710
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x040054CF RID: 21711
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x040054D0 RID: 21712
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040054D1 RID: 21713
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040054D2 RID: 21714
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x040054D3 RID: 21715
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSmoke_Private_Void_0;

		// Token: 0x040054D4 RID: 21716
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0;

		// Token: 0x040054D5 RID: 21717
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0;

		// Token: 0x040054D6 RID: 21718
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0;

		// Token: 0x040054D7 RID: 21719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
