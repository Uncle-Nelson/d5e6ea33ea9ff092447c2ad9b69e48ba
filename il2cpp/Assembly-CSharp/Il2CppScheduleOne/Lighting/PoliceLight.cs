using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B8 RID: 952
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x06004A21 RID: 18977 RVA: 0x001682A0 File Offset: 0x001664A0
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceLight()
		{
			Il2CppClassPointerStore<PoliceLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "PoliceLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr);
			PoliceLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "IsOn");
			PoliceLight.NativeFieldInfoPtr_RedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedMeshes");
			PoliceLight.NativeFieldInfoPtr_BlueMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueMeshes");
			PoliceLight.NativeFieldInfoPtr_RedLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedLights");
			PoliceLight.NativeFieldInfoPtr_BlueLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueLights");
			PoliceLight.NativeFieldInfoPtr_Siren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "Siren");
			PoliceLight.NativeFieldInfoPtr_CycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "CycleDuration");
			PoliceLight.NativeFieldInfoPtr_RedOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOffMat");
			PoliceLight.NativeFieldInfoPtr_RedOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOnMat");
			PoliceLight.NativeFieldInfoPtr_BlueOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOffMat");
			PoliceLight.NativeFieldInfoPtr_BlueOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOnMat");
			PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_LightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "LightBrightness");
			PoliceLight.NativeFieldInfoPtr_cycleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "cycleRoutine");
			PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672487);
			PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672488);
			PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672489);
			PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672490);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x0016844C File Offset: 0x0016664C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x0016848C File Offset: 0x0016668C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163907, XrefRangeEnd = 163909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x001684C0 File Offset: 0x001666C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163909, XrefRangeEnd = 163914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CycleCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00168500 File Offset: 0x00166700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163914, XrefRangeEnd = 163915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00023B9D File Offset: 0x00021D9D
		public PoliceLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x0016853C File Offset: 0x0016673C
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x00023BA6 File Offset: 0x00021DA6
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00168564 File Offset: 0x00166764
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x00023BC1 File Offset: 0x00021DC1
		public unsafe Il2CppReferenceArray<MeshRenderer> RedMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00168594 File Offset: 0x00166794
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00023BE0 File Offset: 0x00021DE0
		public unsafe Il2CppReferenceArray<MeshRenderer> BlueMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x001685C4 File Offset: 0x001667C4
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00023BFF File Offset: 0x00021DFF
		public unsafe Il2CppReferenceArray<OptimizedLight> RedLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x001685F4 File Offset: 0x001667F4
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x00023C1E File Offset: 0x00021E1E
		public unsafe Il2CppReferenceArray<OptimizedLight> BlueLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x00168624 File Offset: 0x00166824
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00023C3D File Offset: 0x00021E3D
		public unsafe AudioSourceController Siren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x00168654 File Offset: 0x00166854
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x00023C5C File Offset: 0x00021E5C
		public unsafe float CycleDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration)) = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x0016867C File Offset: 0x0016687C
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x00023C77 File Offset: 0x00021E77
		public unsafe Material RedOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x001686AC File Offset: 0x001668AC
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x00023C96 File Offset: 0x00021E96
		public unsafe Material RedOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x001686DC File Offset: 0x001668DC
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x00023CB5 File Offset: 0x00021EB5
		public unsafe Material BlueOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x0016870C File Offset: 0x0016690C
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x00023CD4 File Offset: 0x00021ED4
		public unsafe Material BlueOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x0016873C File Offset: 0x0016693C
		// (set) Token: 0x06004A3E RID: 19006 RVA: 0x00023CF3 File Offset: 0x00021EF3
		public unsafe AnimationCurve RedBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x0016876C File Offset: 0x0016696C
		// (set) Token: 0x06004A40 RID: 19008 RVA: 0x00023D12 File Offset: 0x00021F12
		public unsafe AnimationCurve BlueBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x0016879C File Offset: 0x0016699C
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x00023D31 File Offset: 0x00021F31
		public unsafe float LightBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness)) = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x001687C4 File Offset: 0x001669C4
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x00023D4C File Offset: 0x00021F4C
		public unsafe Coroutine cycleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeFieldInfoPtr_RedMeshes;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeFieldInfoPtr_BlueMeshes;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeFieldInfoPtr_RedLights;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeFieldInfoPtr_BlueLights;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeFieldInfoPtr_Siren;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeFieldInfoPtr_CycleDuration;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeFieldInfoPtr_RedOffMat;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeFieldInfoPtr_RedOnMat;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeFieldInfoPtr_BlueOffMat;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeFieldInfoPtr_BlueOnMat;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeFieldInfoPtr_RedBrightnessCurve;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeFieldInfoPtr_BlueBrightnessCurve;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeFieldInfoPtr_LightBrightness;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeFieldInfoPtr_cycleRoutine;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000986 RID: 2438
		[ObfuscatedName("ScheduleOne.Lighting.PoliceLight+<CycleCoroutine>d__17")]
		public sealed class _CycleCoroutine_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600CA3A RID: 51770 RVA: 0x0030EA78 File Offset: 0x0030CC78
			// Note: this type is marked as 'beforefieldinit'.
			static _CycleCoroutine_d__17()
			{
				Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "<CycleCoroutine>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr);
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>1__state");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>2__current");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>4__this");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<time>5__2");
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672491);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672492);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672493);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672494);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672495);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672496);
			}

			// Token: 0x0600CA3B RID: 51771 RVA: 0x0030EB6C File Offset: 0x0030CD6C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CycleCoroutine_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA3C RID: 51772 RVA: 0x0030EBB4 File Offset: 0x0030CDB4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA3D RID: 51773 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163868, XrefRangeEnd = 163902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F07 RID: 16135
			// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x0030EC24 File Offset: 0x0030CE24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA3F RID: 51775 RVA: 0x0030EC64 File Offset: 0x0030CE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163902, XrefRangeEnd = 163907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F08 RID: 16136
			// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x0030EC98 File Offset: 0x0030CE98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA41 RID: 51777 RVA: 0x00062539 File Offset: 0x00060739
			public _CycleCoroutine_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F03 RID: 16131
			// (get) Token: 0x0600CA42 RID: 51778 RVA: 0x0030ECD8 File Offset: 0x0030CED8
			// (set) Token: 0x0600CA43 RID: 51779 RVA: 0x00062542 File Offset: 0x00060742
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F04 RID: 16132
			// (get) Token: 0x0600CA44 RID: 51780 RVA: 0x0030ED00 File Offset: 0x0030CF00
			// (set) Token: 0x0600CA45 RID: 51781 RVA: 0x0006255D File Offset: 0x0006075D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F05 RID: 16133
			// (get) Token: 0x0600CA46 RID: 51782 RVA: 0x0030ED30 File Offset: 0x0030CF30
			// (set) Token: 0x0600CA47 RID: 51783 RVA: 0x0006257C File Offset: 0x0006077C
			public unsafe PoliceLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F06 RID: 16134
			// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x0030ED60 File Offset: 0x0030CF60
			// (set) Token: 0x0600CA49 RID: 51785 RVA: 0x0006259B File Offset: 0x0006079B
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x040088CC RID: 35020
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088CD RID: 35021
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088CE RID: 35022
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088CF RID: 35023
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x040088D0 RID: 35024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088D1 RID: 35025
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088D2 RID: 35026
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088D3 RID: 35027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088D4 RID: 35028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088D5 RID: 35029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
