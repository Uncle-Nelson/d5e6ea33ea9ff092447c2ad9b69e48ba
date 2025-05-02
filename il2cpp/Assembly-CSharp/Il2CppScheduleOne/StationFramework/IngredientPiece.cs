using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058A RID: 1418
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x06007CCD RID: 31949 RVA: 0x00217FE4 File Offset: 0x002161E4
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientPiece()
		{
			Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientPiece");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr);
			IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LIQUID_FRICTION");
			IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<CurrentDissolveAmount>k__BackingField");
			IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "CurrentLiquidContainer");
			IngredientPiece.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "ModelContainer");
			IngredientPiece.NativeFieldInfoPtr_DissolveParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DissolveParticles");
			IngredientPiece.NativeFieldInfoPtr_DetectLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DetectLiquid");
			IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DisableInteractionInLiquid");
			IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LiquidFrictionMultiplier");
			IngredientPiece.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "draggable");
			IngredientPiece.NativeFieldInfoPtr_defaultDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "defaultDrag");
			IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "dissolveParticleRoutine");
			IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678931);
			IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678932);
			IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678933);
			IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678934);
			IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678935);
			IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678936);
			IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678937);
			IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678938);
			IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678939);
			IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678940);
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x002181B8 File Offset: 0x002163B8
		// (set) Token: 0x06007CCF RID: 31951 RVA: 0x002181F4 File Offset: 0x002163F4
		public unsafe float CurrentDissolveAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x00218234 File Offset: 0x00216434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237723, XrefRangeEnd = 237730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x00218268 File Offset: 0x00216468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237730, XrefRangeEnd = 237734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x0021829C File Offset: 0x0021649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237734, XrefRangeEnd = 237735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x002182D0 File Offset: 0x002164D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237755, RefRangeEnd = 237756, XrefRangeStart = 237735, XrefRangeEnd = 237755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00218304 File Offset: 0x00216504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237756, XrefRangeEnd = 237772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x00218338 File Offset: 0x00216538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237787, RefRangeEnd = 237788, XrefRangeStart = 237772, XrefRangeEnd = 237787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DissolveAmount(float amount, bool showParticles = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00218384 File Offset: 0x00216584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237788, XrefRangeEnd = 237789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientPiece() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x002183C0 File Offset: 0x002165C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237789, XrefRangeEnd = 237794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x0003B3F3 File Offset: 0x000395F3
		public IngredientPiece(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x00218400 File Offset: 0x00216600
		// (set) Token: 0x06007CDA RID: 31962 RVA: 0x0003B3FC File Offset: 0x000395FC
		public unsafe static float LIQUID_FRICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&value));
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x0021841C File Offset: 0x0021661C
		// (set) Token: 0x06007CDC RID: 31964 RVA: 0x0003B40A File Offset: 0x0003960A
		public unsafe float _CurrentDissolveAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06007CDD RID: 31965 RVA: 0x00218444 File Offset: 0x00216644
		// (set) Token: 0x06007CDE RID: 31966 RVA: 0x0003B425 File Offset: 0x00039625
		public unsafe LiquidContainer CurrentLiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06007CDF RID: 31967 RVA: 0x00218474 File Offset: 0x00216674
		// (set) Token: 0x06007CE0 RID: 31968 RVA: 0x0003B444 File Offset: 0x00039644
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x002184A4 File Offset: 0x002166A4
		// (set) Token: 0x06007CE2 RID: 31970 RVA: 0x0003B463 File Offset: 0x00039663
		public unsafe ParticleSystem DissolveParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x002184D4 File Offset: 0x002166D4
		// (set) Token: 0x06007CE4 RID: 31972 RVA: 0x0003B482 File Offset: 0x00039682
		public unsafe bool DetectLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid)) = value;
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06007CE5 RID: 31973 RVA: 0x002184FC File Offset: 0x002166FC
		// (set) Token: 0x06007CE6 RID: 31974 RVA: 0x0003B49D File Offset: 0x0003969D
		public unsafe bool DisableInteractionInLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid)) = value;
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06007CE7 RID: 31975 RVA: 0x00218524 File Offset: 0x00216724
		// (set) Token: 0x06007CE8 RID: 31976 RVA: 0x0003B4B8 File Offset: 0x000396B8
		public unsafe float LiquidFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier)) = value;
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06007CE9 RID: 31977 RVA: 0x0021854C File Offset: 0x0021674C
		// (set) Token: 0x06007CEA RID: 31978 RVA: 0x0003B4D3 File Offset: 0x000396D3
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06007CEB RID: 31979 RVA: 0x0021857C File Offset: 0x0021677C
		// (set) Token: 0x06007CEC RID: 31980 RVA: 0x0003B4F2 File Offset: 0x000396F2
		public unsafe float defaultDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag)) = value;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x002185A4 File Offset: 0x002167A4
		// (set) Token: 0x06007CEE RID: 31982 RVA: 0x0003B50D File Offset: 0x0003970D
		public unsafe Coroutine dissolveParticleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054F3 RID: 21747
		private static readonly IntPtr NativeFieldInfoPtr_LIQUID_FRICTION;

		// Token: 0x040054F4 RID: 21748
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField;

		// Token: 0x040054F5 RID: 21749
		private static readonly IntPtr NativeFieldInfoPtr_CurrentLiquidContainer;

		// Token: 0x040054F6 RID: 21750
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x040054F7 RID: 21751
		private static readonly IntPtr NativeFieldInfoPtr_DissolveParticles;

		// Token: 0x040054F8 RID: 21752
		private static readonly IntPtr NativeFieldInfoPtr_DetectLiquid;

		// Token: 0x040054F9 RID: 21753
		private static readonly IntPtr NativeFieldInfoPtr_DisableInteractionInLiquid;

		// Token: 0x040054FA RID: 21754
		private static readonly IntPtr NativeFieldInfoPtr_LiquidFrictionMultiplier;

		// Token: 0x040054FB RID: 21755
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x040054FC RID: 21756
		private static readonly IntPtr NativeFieldInfoPtr_defaultDrag;

		// Token: 0x040054FD RID: 21757
		private static readonly IntPtr NativeFieldInfoPtr_dissolveParticleRoutine;

		// Token: 0x040054FE RID: 21758
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0;

		// Token: 0x040054FF RID: 21759
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0;

		// Token: 0x04005500 RID: 21760
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005501 RID: 21761
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005502 RID: 21762
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04005503 RID: 21763
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_0;

		// Token: 0x04005504 RID: 21764
		private static readonly IntPtr NativeMethodInfoPtr_CheckLiquid_Private_Void_0;

		// Token: 0x04005505 RID: 21765
		private static readonly IntPtr NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0;

		// Token: 0x04005506 RID: 21766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005507 RID: 21767
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("ScheduleOne.StationFramework.IngredientPiece+<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D3E9 RID: 54249 RVA: 0x003299D8 File Offset: 0x00327BD8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678941);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678942);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678943);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678944);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678945);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678946);
			}

			// Token: 0x0600D3EA RID: 54250 RVA: 0x00329AB8 File Offset: 0x00327CB8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3EB RID: 54251 RVA: 0x00329B00 File Offset: 0x00327D00
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3EC RID: 54252 RVA: 0x00329B34 File Offset: 0x00327D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237713, XrefRangeEnd = 237718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041B7 RID: 16823
			// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x00329B70 File Offset: 0x00327D70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3EE RID: 54254 RVA: 0x00329BB0 File Offset: 0x00327DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237718, XrefRangeEnd = 237723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041B8 RID: 16824
			// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x00329BE4 File Offset: 0x00327DE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3F0 RID: 54256 RVA: 0x0006729A File Offset: 0x0006549A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0600D3F1 RID: 54257 RVA: 0x00329C24 File Offset: 0x00327E24
			// (set) Token: 0x0600D3F2 RID: 54258 RVA: 0x000672A3 File Offset: 0x000654A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041B5 RID: 16821
			// (get) Token: 0x0600D3F3 RID: 54259 RVA: 0x00329C4C File Offset: 0x00327E4C
			// (set) Token: 0x0600D3F4 RID: 54260 RVA: 0x000672BE File Offset: 0x000654BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x00329C7C File Offset: 0x00327E7C
			// (set) Token: 0x0600D3F6 RID: 54262 RVA: 0x000672DD File Offset: 0x000654DD
			public unsafe IngredientPiece __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientPiece>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EB8 RID: 36536
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EB9 RID: 36537
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EBA RID: 36538
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EBB RID: 36539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EBC RID: 36540
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EBD RID: 36541
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EBE RID: 36542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EBF RID: 36543
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EC0 RID: 36544
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
