using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000743 RID: 1859
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x0600AC88 RID: 44168 RVA: 0x002B0F30 File Offset: 0x002AF130
		// Note: this type is marked as 'beforefieldinit'.
		static StirringRod()
		{
			Il2CppClassPointerStore<StirringRod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "StirringRod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StirringRod>.NativeClassPtr);
			StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_STIR_RATE");
			StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_PIVOT_ANGLE");
			StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<Interactable>k__BackingField");
			StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<CurrentStirringSpeed>k__BackingField");
			StirringRod.NativeFieldInfoPtr_LerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "LerpSpeed");
			StirringRod.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Clickable");
			StirringRod.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "PlaneNormal");
			StirringRod.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Container");
			StirringRod.NativeFieldInfoPtr_RodPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "RodPivot");
			StirringRod.NativeFieldInfoPtr_StirSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "StirSound");
			StirringRod.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "clickOffset");
			StirringRod.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "isMoving");
			StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684471);
			StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684472);
			StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684473);
			StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684474);
			StirringRod.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684475);
			StirringRod.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684476);
			StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684477);
			StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684478);
			StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684479);
			StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684480);
			StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684481);
			StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684482);
			StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684483);
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x002B1154 File Offset: 0x002AF354
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x002B1190 File Offset: 0x002AF390
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x002B11D0 File Offset: 0x002AF3D0
		// (set) Token: 0x0600AC8C RID: 44172 RVA: 0x002B120C File Offset: 0x002AF40C
		public unsafe float CurrentStirringSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x002B124C File Offset: 0x002AF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299105, XrefRangeEnd = 299122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC8E RID: 44174 RVA: 0x002B1280 File Offset: 0x002AF480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299122, XrefRangeEnd = 299126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x002B12B4 File Offset: 0x002AF4B4
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x002B12E8 File Offset: 0x002AF4E8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 299126, RefRangeEnd = 299141, XrefRangeStart = 299126, XrefRangeEnd = 299126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x002B1328 File Offset: 0x002AF528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299141, XrefRangeEnd = 299144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x002B1368 File Offset: 0x002AF568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299157, RefRangeEnd = 299158, XrefRangeStart = 299144, XrefRangeEnd = 299157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x002B13A4 File Offset: 0x002AF5A4
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x002B13D8 File Offset: 0x002AF5D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299163, RefRangeEnd = 299165, XrefRangeStart = 299158, XrefRangeEnd = 299163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x002B140C File Offset: 0x002AF60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299165, XrefRangeEnd = 299168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StirringRod() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StirringRod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x00054E29 File Offset: 0x00053029
		public StirringRod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002B1448 File Offset: 0x002AF648
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x00054E32 File Offset: 0x00053032
		public unsafe static float MAX_STIR_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&value));
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x002B1464 File Offset: 0x002AF664
		// (set) Token: 0x0600AC9A RID: 44186 RVA: 0x00054E40 File Offset: 0x00053040
		public unsafe static float MAX_PIVOT_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600AC9B RID: 44187 RVA: 0x002B1480 File Offset: 0x002AF680
		// (set) Token: 0x0600AC9C RID: 44188 RVA: 0x00054E4E File Offset: 0x0005304E
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x002B14A8 File Offset: 0x002AF6A8
		// (set) Token: 0x0600AC9E RID: 44190 RVA: 0x00054E69 File Offset: 0x00053069
		public unsafe float _CurrentStirringSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600AC9F RID: 44191 RVA: 0x002B14D0 File Offset: 0x002AF6D0
		// (set) Token: 0x0600ACA0 RID: 44192 RVA: 0x00054E84 File Offset: 0x00053084
		public unsafe float LerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed)) = value;
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x002B14F8 File Offset: 0x002AF6F8
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x00054E9F File Offset: 0x0005309F
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x002B1528 File Offset: 0x002AF728
		// (set) Token: 0x0600ACA4 RID: 44196 RVA: 0x00054EBE File Offset: 0x000530BE
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600ACA5 RID: 44197 RVA: 0x002B1558 File Offset: 0x002AF758
		// (set) Token: 0x0600ACA6 RID: 44198 RVA: 0x00054EDD File Offset: 0x000530DD
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002B1588 File Offset: 0x002AF788
		// (set) Token: 0x0600ACA8 RID: 44200 RVA: 0x00054EFC File Offset: 0x000530FC
		public unsafe Transform RodPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x002B15B8 File Offset: 0x002AF7B8
		// (set) Token: 0x0600ACAA RID: 44202 RVA: 0x00054F1B File Offset: 0x0005311B
		public unsafe AudioSourceController StirSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600ACAB RID: 44203 RVA: 0x002B15E8 File Offset: 0x002AF7E8
		// (set) Token: 0x0600ACAC RID: 44204 RVA: 0x00054F3A File Offset: 0x0005313A
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x002B1610 File Offset: 0x002AF810
		// (set) Token: 0x0600ACAE RID: 44206 RVA: 0x00054F55 File Offset: 0x00053155
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040073FC RID: 29692
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STIR_RATE;

		// Token: 0x040073FD RID: 29693
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PIVOT_ANGLE;

		// Token: 0x040073FE RID: 29694
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040073FF RID: 29695
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField;

		// Token: 0x04007400 RID: 29696
		private static readonly IntPtr NativeFieldInfoPtr_LerpSpeed;

		// Token: 0x04007401 RID: 29697
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04007402 RID: 29698
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007403 RID: 29699
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007404 RID: 29700
		private static readonly IntPtr NativeFieldInfoPtr_RodPivot;

		// Token: 0x04007405 RID: 29701
		private static readonly IntPtr NativeFieldInfoPtr_StirSound;

		// Token: 0x04007406 RID: 29702
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04007407 RID: 29703
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04007408 RID: 29704
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007409 RID: 29705
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x0400740A RID: 29706
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0;

		// Token: 0x0400740B RID: 29707
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0;

		// Token: 0x0400740C RID: 29708
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400740D RID: 29709
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400740E RID: 29710
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400740F RID: 29711
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007410 RID: 29712
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007411 RID: 29713
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04007412 RID: 29714
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007413 RID: 29715
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04007414 RID: 29716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
